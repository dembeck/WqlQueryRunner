# WqlQueryRunner
This is copied from a CodePlex project.


![](ReadMe/Home_image2.jpg)

**Project Description**

WQL Query Runner is (or would be) a tool for WMI SQL query testing.

There are different types of WQL queries. My plan is to support creating all of them, and the first type for which I decided to add support are WQL event queries. 

WMI is the Microsoft implementation of WBEM, the industry initiative for computer and network management. It allows you to manage most computer assets in a uniform way. There are several APIs that you can use to access WMI, and most of them utilize WQL queries. WQL is a query language derived from SQL - you can think of it as a simplified SQL language. 

The main difficulty when creating WQL queries is not its syntax, but choosing the right WMI objects to SELECT data from and the goal of the utility is to make constructing and testing WQL queries easier.

There are different types of WQL queries, and my plan is to support creating all of them, and the first for which I decided to add support are WQL event queries. The utility provides a way to enter and test event WQL queries locally and also features a wizard that attempts to walk you through all WQL event query elements.

![](ReadMe/Home_image3.jpg)

As you can see, this is my first .Net project. I am a system administrator, not a developer, so creating this application involved a lot of learning with little success. So why did I decide to start this? In short, because noone else did. There are several tools out there that help you work with WMI, like WMI tester (wbemtest.exe) that comes with Windows, WMI Tools (a free Microsoft download), WMI Scriptomatic (also a free download from the Microsoft Scripting guys) and WMI Code Creator, but none of these tools concentrate solely on WQL queries - WMI Tester and WMI Tools facilitate browsing the WMI schema, and Scriptomatic and Wmi Code Creator allow you to generate VBScript, C# (and other) code.

It's also been great fun. So until someone that really knows what he's doing starts a similar project, I will continue to work on this one.

2011-02-19

Added a new form to the project that allows you to run ordinary (data) WQL queries. The form is called WQL Query Editor and is similar to the old SQL Server 2000 Query Analyzer. 

![](ReadMe/Home_queryeditor2.jpg)

You can browse available WMI namespaces and classes on the local computer using the TreeView control on the right hand side and execute queries entered in the upper RichTextBox. The results are shown in the lower RichTextBox and can also be viewed in a DataGridView control.

Query Editor can be started from the main window context menu:

![](ReadMe/Home_queryeditor1.jpg)

or by using a command line switch:

WqlQueryRunner.exe queryeditor

WQL Query Editor takes a couple of seconds to show because it enumerates all available WMI namespace when it starts.
