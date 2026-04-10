Imports OfficeOpenXml

Module Module1

    Sub Main()

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Dim list = new List(Of RegistroExportacionExcel)()

        Dim p = New OfficeOpenXml.ExcelPackage
        Dim ws = p.Workbook.Worksheets.Add($"Test V5 - {DateTime.Now.ToShortDateString()}")

        ws.Cells(1, 1).LoadFromCollection(list, True, OfficeOpenXml.Table.TableStyles.Light5)

        For col = 1 To ws.Dimension.Columns
            If ws.Cells(1, col).Value.ToString().StartsWith("Fecha") AndAlso ws.Dimension.Rows > 1 Then
                ws.Cells(2, col, ws.Dimension.Rows, col).Style.Numberformat.Format = "dd/MM/yyyy HH:mm:ss"
            End If
        Next

        ws.Cells(ws.Dimension.Address).AutoFitColumns()

        Dim path = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Test V5 - {DateTime.Now:yyyy-MM-dd}.xlsx")
        Dim file = New IO.FileInfo(path)

        p.SaveAsAsync(file).Wait()

        Process.Start(New System.Diagnostics.ProcessStartInfo With {.FileName = path, .UseShellExecute = True})

    End Sub

End Module
