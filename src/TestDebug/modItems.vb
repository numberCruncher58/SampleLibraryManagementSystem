' Table-Item Manipulation Module
' Created by Bart Cabuyao
' Created 7/3/2022, 3:33p

Module modItems

    Sub MoveItem(ByVal SourceList As ListView, ByVal DestinationList As ListView)

        '   MoveItem() is a procedure that requires two ListView control as parameter.
        '   It moves a focused item from the SourceList to DestinationList.

        Dim Item As New ListViewItem

        If IsNothing(SourceList.FocusedItem) Then
            Exit Sub
        End If

        Item = SourceList.FocusedItem
        SourceList.Items.Remove(Item)
        DestinationList.Items.Add(Item)

    End Sub

End Module
