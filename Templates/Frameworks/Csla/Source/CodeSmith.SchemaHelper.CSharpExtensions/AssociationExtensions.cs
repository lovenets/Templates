﻿using System;
using System.Collections.Generic;

namespace CodeSmith.SchemaHelper
{
    /// <summary>
    /// Extension Methods for AssociationExtensions
    /// </summary>
    public static class AssociationExtensions
    {
        public static string BuildObjectInitializer(this IAssociation association)
        {
            return association.BuildObjectInitializer(false);
        }

        public static string BuildObjectInitializer(this IAssociation association, bool usePropertyName)
        {
            string parameters = String.Empty;

            foreach (IProperty property in association.SearchCriteria.Properties)
            {
                foreach (AssociationProperty associationProperty in association.Properties)
                {
                    if (property.KeyName == associationProperty.Property.KeyName && property == associationProperty.Property)
                    {
                        if (associationProperty.Property.IsNullable && associationProperty.Property.SystemType != "System.String" && associationProperty.Property.SystemType != "System.Byte[]") 
                            continue;

                        parameters += String.Format(", {0} = {1}", associationProperty.ForeignProperty.Name,
                            usePropertyName ? associationProperty.Property.Name : associationProperty.Property.VariableName);
                    }
                }
            }

            return parameters.TrimStart(new[] { ',', ' ' });
        }

        public static string BuildNullableObjectInitializer(this IAssociation association)
        {
            return association.BuildNullableObjectInitializer(false);
        }

        public static string BuildNullableObjectInitializer(this IAssociation association, bool usePropertyName)
        {
            string parameters = String.Empty;

            foreach (IProperty property in association.SearchCriteria.Properties)
            {
                foreach (AssociationProperty associationProperty in association.Properties)
                {
                    if (property.KeyName == associationProperty.Property.KeyName && property == associationProperty.Property)
                    {
                        if ((associationProperty.Property.IsNullable && associationProperty.Property.SystemType != "System.String" && associationProperty.Property.SystemType != "System.Byte[]") == false) 
                            continue;

                        parameters += String.Format("\r\n                if({1}.HasValue) criteria.{0} = {1}.Value;", associationProperty.ForeignProperty.Name,
                            usePropertyName ? associationProperty.Property.Name : associationProperty.Property.VariableName);
                    }
                }
            }

            return parameters.TrimStart(new[] { '\r', '\n', ' ' });
        }

        /// <summary>
        /// Builds a null check HasValue Statements for the Property Templates.
        /// </summary>
        /// <param name="association"></param>
        /// <returns></returns>
        public static string BuildNullCheckStatement(this IAssociation association)
        {
            return association.BuildNullCheckStatement(false, true, false, false);
        }

        /// <summary>
        /// Builds a null check HasValue Statements for the Property Templates.
        /// </summary>
        /// <param name="association"></param>
        /// <param name="usePropertyName"></param>
        /// <param name="useNot"></param>
        /// <param name="useAndAlso"></param>
        /// <param name="trimEnd"></param>
        /// <returns></returns>
        public static string BuildNullCheckStatement(this IAssociation association, bool usePropertyName, bool useNot, bool useAndAlso, bool trimEnd)
        {
            return association.BuildNullCheckStatement(false, true, false, false, null);
        }

        /// <summary>
        /// Builds a null check HasValue Statements for the Property Templates.
        /// </summary>
        /// <param name="association"></param>
        /// <param name="usePropertyName"></param>
        /// <param name="useNot"></param>
        /// <param name="useAndAlso"></param>
        /// <param name="trimEnd"></param>
        /// <param name="nullExpression">If this value is not set to null and the parameters is blank, then this exspression will be returned.</param>
        /// <returns></returns>
        public static string BuildNullCheckStatement(this IAssociation association, bool usePropertyName, bool useNot, bool useAndAlso, bool trimEnd, bool? nullExpression)
        {
            string exspression = useAndAlso ? "&& " : "|| ";
            string lastParameter = String.Empty;
            string parameters = String.Empty;

            foreach (IProperty property in association.SearchCriteria.Properties)
            {
                foreach (AssociationProperty associationProperty in association.Properties)
                {
                    if (property.KeyName == associationProperty.Property.KeyName && property == associationProperty.Property)
                    {
                        if ((associationProperty.Property.IsNullable && associationProperty.Property.SystemType != "System.String" && associationProperty.Property.SystemType != "System.Byte[]") == false) 
                            continue;

                        lastParameter = parameters.Length == 0 ?
                            String.Format("({0}{1}.HasValue {2}", useNot ? "!" : String.Empty, usePropertyName ? associationProperty.Property.Name : associationProperty.Property.VariableName, exspression) :
                            String.Format(" {0}{1}.HasValue {2}", useNot ? "!" : String.Empty, usePropertyName ? associationProperty.Property.Name : associationProperty.Property.VariableName, exspression);

                        parameters += lastParameter;
                    }
                }
            }

            // If there are no parameters then return.
            if (parameters.Length == 0)
            {
                if (!nullExpression.HasValue)
                    return String.Empty;

                return nullExpression.Value ? "(true)" : "(false)";
            }

            // Insert the last paren.
            parameters = parameters.Replace(lastParameter, lastParameter.Insert(lastParameter.IndexOf("HasValue") + 8, ")"));

            // Remove the last exspression if needed.
            if(trimEnd)
                parameters = parameters.Remove(parameters.Length - exspression.Length);

            // Remove leading characters.
            return parameters.TrimStart(new[] { ' ' });
        }

        public static string BuildParametersVariables(this IAssociation association)
        {
            return association.BuildParametersVariables(false);
        }

        public static string BuildParametersVariables(this IAssociation association, bool includeConnectionParameter)
        {
            string parameters = String.Empty;

            foreach (AssociationProperty property in association.Properties)
            {
                var parameter = String.Format(", {0} {1}", property.ForeignProperty.Entity.Name, property.ForeignProperty.Entity.VariableName);
                if (!parameters.Contains(parameter))
                    parameters += parameter;
            }

            if (includeConnectionParameter)
                parameters += ", SqlConnection connection";

            return parameters.TrimStart(new[] { ',', ' ' });
        }

        public static string BuildUpdateStatementVariables(this IAssociation association, List<IAssociation> associations, int currentRecord, bool includeConnectionParameter)
        {
            string parameters = String.Empty;

            for (int index = 0; index < associations.Count; index++)
            {
                var parameter = String.Format(", {0}", associations[index].ForeignEntity.VariableName);
                if(index == currentRecord)
                {
                    parameters += parameter;
                }
                else
                {
                    parameters += ", null";
                }
            }

            if (includeConnectionParameter)
                parameters += ", connection";

            return parameters.TrimStart(new[] { ',', ' ' });
        }
    }
}