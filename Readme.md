<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598150/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5144)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WinForms - Salary Reports

This example generates a salary report for each employee and a summary report for the management department.

The app illustrates the following reporting features: [bands](https://docs.devexpress.com/XtraReports/2587/detailed-guide-to-devexpress-reporting/introduction-to-banded-reports) and [controls](https://docs.devexpress.com/XtraReports/2605/detailed-guide-to-devexpress-reporting/use-report-controls?p=netframework), [calculated fields](https://docs.devexpress.com/XtraReports/4813/detailed-guide-to-devexpress-reporting/shape-report-data/use-calculated-fields/calculated-fields-overview), [appearance](https://docs.devexpress.com/XtraReports/2573/desktop-reporting/winforms-reporting/winforms-reporting-application-appearance/change-the-application-skin), [format rules](https://docs.devexpress.com/XtraReports/119473/detailed-guide-to-devexpress-reporting/use-expressions/expressions-tasks-and-solutions/conditionally-change-a-controls-appearance), [parameters](https://docs.devexpress.com/XtraReports/4812/detailed-guide-to-devexpress-reporting/use-report-parameters?p=netframework), [summaries](https://docs.devexpress.com/XtraReports/403729/detailed-guide-to-devexpress-reporting/shape-report-data/calculate-summaries/calculate-summaries-overview), a [summary chart](https://docs.devexpress.com/XtraReports/2609/detailed-guide-to-devexpress-reporting/use-report-controls/use-charts/use-charts-in-reports), [table of content](https://docs.devexpress.com/XtraReports/115661/detailed-guide-to-devexpress-reporting/add-navigation/add-a-table-of-contents?p=netframework), and more.

The main application points:

1. The capability to create employee salary and summary reports for a given month.

2. Each employee salary report provides the following:
   - Employee credentials, contacts and position
   - The number of sick leaves and overtime (in days) in the month
   - An income calculated from position, salary and overtime

   ![employee-salary-report](/images/employee-salary-report.png)

3. The summary report displays the following:
   - Information about salaries grouped by department
   - Summary information for sick leaves and overtime in each department
   - A summary chart for the summary information related to each department

   ![summary-report](/images/summary-report.png)

4. A management interface presented to the user for report generation:
   
   ![management-screenshot](/images/screenshot.png)

5. Report data is bound to a database.

## Documentation

- [Create a Report from A to Z](https://docs.devexpress.com/XtraReports/2440/get-started-with-devexpress-reporting/create-a-report-from-a-to-z)
- [Create Different Report Types (Walkthroughs)](https://docs.devexpress.com/XtraReports/5152/create-reports)
- [Detailed Guide to DevExpress Reporting](https://docs.devexpress.com/XtraReports/5150/detailed-guide-to-devexpress-reporting)

## More Examples

- [How to Create a Report Bound to the SQL Data Source](https://github.com/DevExpress-Examples/reporting-winforms-sql-data-source-runtime)
- [Reporting for WinForms - Create a Data-Bound Table at Runtime](https://github.com/DevExpress-Examples/reporting-create-table-at-runtime)
- [Create a Cross-Tab Report in Code](https://docs.devexpress.com/XtraReports/403673/detailed-guide-to-devexpress-reporting/reporting-api/create-reports-in-code/create-a-cross-tab-report) 
- [Reporting - Use a Multi-Value Parameter as a Table Column Chooser](https://github.com/DevExpress-Examples/reporting-use-multi-value-parameter-as-table-column-chooser)
- [Reporting for WinForms - Use Subreport Control to Add a Chart](https://github.com/DevExpress-Examples/Reporting-Use-Subreport-To-Add-A-Chart)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-salary-reports&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-salary-reports&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
