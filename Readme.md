<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653609/11.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1861)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Data Grid - Bind to Server Mode with XPO

This example shows the WPF Data Grid bound to the [XPServerCollectionSource](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPServerCollectionSource). You should restore the **NorthwindXpo** database from the backup file on your SQL Server prior to running the sample. When the Data Grid works in [Server Mode](https://docs.devexpress.com/WPF/6279/controls-and-libraries/data-grid/bind-to-data/server-mode-and-instant-feedback), data operations (filter, sort, group) are performed at the database server level. SQL queries generated by [XPO](http://www.devexpress.com/xpo) are displayed in a text box under the Data Grid.

## Files to Look At

* [NorthwindXpo.cs](./CS/XpoNorthwindServerMode/NorthwindXpo.cs) (VB: [NorthwindXpo.vb](./VB/XpoNorthwindServerMode/NorthwindXpo.vb))
* [Window1.xaml](./CS/XpoNorthwindServerMode/Window1.xaml) (VB: [Window1.xaml](./VB/XpoNorthwindServerMode/Window1.xaml))
* [Window1.xaml.cs](./CS/XpoNorthwindServerMode/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/XpoNorthwindServerMode/Window1.xaml.vb))

## More Examples

The following example shows how to bind the WPF Data Grid to different data sources: [Bind the WPF Data Grid to Data](https://github.com/DevExpress-Examples/how-to-bind-wpf-grid-to-data).

This example includes multiple solutions that demonstrate:
* How to bind the Data Grid to Entity Framework, EF Core, and XPO.
* Different binding mechanisms: virtual sources, server mode sources, and local data.
* MVVM and code-behind patterns.

After you bind the Data Grid to a database, you can implement CRUD operations (create, read update, delete). View the example: [Implement CRUD Operations in the WPF Data Grid](https://github.com/DevExpress-Examples/how-to-implement-crud-operations).
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-in-server-mode-with-xpo&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-in-server-mode-with-xpo&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
