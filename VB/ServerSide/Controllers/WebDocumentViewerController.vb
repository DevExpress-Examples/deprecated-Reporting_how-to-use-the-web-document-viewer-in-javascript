Imports DevExpress.Web.Mvc.Controllers
Imports DevExpress.XtraReports.Web.Extensions
Imports System.Linq
Imports System.Web.Mvc

Namespace ServerSide.Controllers
    Public Class WebDocumentViewerController
        Inherits WebDocumentViewerApiController

        Public Overrides Function Invoke() As ActionResult
            Dim result = MyBase.Invoke()
            ' Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*")
            Return result
        End Function

        <HttpPost> _
        Public Function GetReports() As ActionResult
            Response.AppendHeader("Access-Control-Allow-Origin", "*")
            Dim result = New JsonResult With {.Data = ReportStorageWebService.GetUrls().ToArray()}
            Return result
        End Function
    End Class
End Namespace