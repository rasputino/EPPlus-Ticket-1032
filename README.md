# Sample project for EPPlus Software support ticket #1032

## EPPlus: Add sample project with model and Excel export

There are two projects: one using version 5 and another using version 7. If you run each project separately, you will see that the Excel file produced by each one has different headers.

A VB.NET test project is added to explore Excel export with EPPlus v5/v7. It includes base and specific record classes with export attributes, language resources, project configuration, and a `Module1` example that generates an empty Excel file on the desktop. This helps validate integration and spreadsheet customization with EPPlus and internationalization.