# TulScan

### About
***
This is a simple application that uses Jira APIs to add issues quickly to a project. In this case adding new assets to an asset project and prints a label via Brother label printer.

### Workflow
***
1. Details are recorded on the AssetWindow.xaml form
2. Once Submitted, it will go through the NewAssetCommand.cs (Here you can add CanExecute paramaters)
3. It then goes to the SubmitAsset() function in the ViewModel (AssetVM.cs) which in turn:
4. Binds the form details to the JiraRequest class
5. (If Summary contains "Godzilla" or "godzilla", it will print out a ASCII godzilla and return to the start)
6. It then uses JiraHelper.CreateIssue() to pass the created class into json and send it to the Jira API
7. JiraRequest returns the created key (ASSET-####)
8. Uses the key details to print a brother label using BrotherHelper.PrintAssetLabel()

### Notes
***
* When binding the form bindings to the JiraRequest class you will need to specify the Project and Issuetype Ids of your own Jira.
```
JiraRequest request = new JiraRequest()
{
    Fields = new()
    {
        Summary = _summary,
        Project = new()
        {
            Id = "10111" //id of the jira project
        },
        Issuetype = new()
        {
            Id = "10110" //id of the projects issue type
        },
        WarrantyDate = DateTime.Now.ToString("O"),
        SupportContractDetails = _supportContractDetails,
        AssetSupplier = _assetSupplier,
        SerialNumber = _serialNumber,
        Location = new()
        {
            Id = _location
        },
        DetailedLocation = _detailedLocation,
        HardwareType = new()
        {
            Id = _hardwareType
        },
        ManafactureBrand = _manafactureBrand,
        Model = _model
    }
};
```
* You will need to add your Jira domain in the Jira Helper
`var client = new RestClient("https://DOMAIN-HERE/jira/rest/api/latest/issue");`

* The following code in BrotherHelper is optionial and is only relevent to the assetlabel in Assets
```
//get objects text and change it to the asset variable that was created from JiraHelper.
//F1 and F2 being the objectname on the brother labael
var shrtAssetNumber = assetNumber.Replace("ASSET-", "");
doc.GetObject("F1").Text = shrtAssetNumber;
doc.GetObject("F2").Text = $"https://jira.mediahubaustralia.com.au/jira/browse/{assetNumber}";
```
### ToDo
***
- Add Jira authorization to config window
