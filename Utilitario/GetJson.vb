Imports System.Web.Script.Serialization
Public Class GetJson
    Public Shared Function GetJson(ByVal dt As DataTable) As String
        Dim serializer As JavaScriptSerializer = New JavaScriptSerializer()
        Dim rows As New List(Of Dictionary(Of String, Object))
        Dim row As Dictionary(Of String, Object)

        For Each dr As DataRow In dt.Rows
            row = New Dictionary(Of String, Object)
            For Each col As DataColumn In dt.Columns
                row.Add(col.ColumnName, dr(col))
            Next
            rows.Add(row)
        Next
        Return serializer.Serialize(rows)
    End Function
    Public Shared Function GetJson(ByVal stringXml As String) As String
        Dim json As New JavaScriptSerializer
        Return json.Serialize(stringXml)
    End Function
    Public Shared Function GetJson(ByVal obj As Object) As String
        Dim json As New JavaScriptSerializer
        Return json.Serialize(obj)
    End Function
End Class
