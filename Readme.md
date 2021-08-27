<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599013/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1182)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to conditionally change FormatString


<p>This example demonstrates how you can allow end-users to conditionally change a control's FormatString value.</p><p>For this, a Boolean parameter is created. Its value determines which formatting to implement. Since the actual task is to deliver this functionality to end-users, the only possible way to do this is to use scripts. So, see the <strong>myReport.Detail.Scripts.OnBeforePrint</strong> property in which the corresponding script is being stored.</p><p>If you don't need to spread this functionality to the End-User Designer, you're recommended to handle the Detail band's BeforePrint event in a similar way.</p>

<br/>


