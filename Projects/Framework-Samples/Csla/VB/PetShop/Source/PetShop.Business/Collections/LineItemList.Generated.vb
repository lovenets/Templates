'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItemList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

<Serializable()> _
Public Partial Class LineItemList 
    Inherits BusinessListBase(Of LineItemList, LineItem)

    #Region "Contructor(s)"
    
    Private Sub New()
		AllowNew = true
        MarkAsChild()
	End Sub
    
    #End Region
    
	#Region "Factory Methods"
	
	Public Shared Function NewList() As LineItemList
		Return DataPortal.Create(Of LineItemList)()
	End Function
	
    Public Shared Function GetLineItemList(ByVal orderId As Integer, ByVal lineNum As Integer) As LineItemList
		Return DataPortal.Fetch(Of LineItemList)(new LineItemCriteria(orderId, lineNum))
	End Function
    
    Public Shared Function GetAll() As LineItemList
        Return DataPortal.Fetch(Of LineItemList)(new LineItemCriteria())
    End Function
	
	#End Region
	
	#Region "Business Methods"
	
	Protected Overrides Function AddNewCore() As Object
		Dim item As LineItem = PetShop.Business.LineItem.NewLineItem()
                Me.Add(item)
                Return item
	End Function
	
	#End Region

End Class