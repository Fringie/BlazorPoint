# Blazor for SharePoint
Blazor (Client Side) on SharePoint

This is a sample project to help you get started with hosting blazor on SharePoint Pages, Completely Client Side.

This Project Contains Components to Insert data into lists using forms, uploading attachments, people picker, lookup lists, tables to list items with search, repeat section to add data to another list and will be added as required as soon as published.

Steps to get up and running, you will need [https://dot.net](dot net core 3.0)


## Step 1:

Create your project using this below command

`dotnet new blazorwasm -o [YourProjectName]`
then,
`cd [YourProjectName]/wwwroot`

Now, rename your _index.html_  file to any file name with _.aspx_

Example:
`index.html`
to
`default.aspx`

## Step 2:
Determine your site collection root path. 

for example if you are using . sharepoint site collection with root name "http://sharepoint.com/" . or
"http://sharepoint.com/sites/example"

either way edit your _default.aspx_ file to reflect the base meta tag

Example:

for root path
`<base href="/default.aspx" />`

for _sites/example_ path
`<base href="/sites/example/default.aspx" />`

if you are hosting in _Pages_ Library
`<base href="/sites/example/Pages/default.aspx" />`

## Step 3:

Allow .json in Central admin then

`Manage WebApp -> Block Types -> Remove json-> save`

Modify your Web Applications Web.Config and add or replace this line if it already exists.

`<add name="JSONHandlerFactory" allowPathInfo="true" path="/*.json" verb="*" type="System.Web.Script.Services.ScriptHandlerFactory, System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" resourceType="Unspecified" preCondition="integratedMode" />`

if you want to allow .json file only on pages library

change path attribute to `path="/Pages/*.json"`

 Contributors

- Syed Mohammed Jafary <syedmohmad@gmail.com>
[S.M.J Ltd](https://www.smj.ltd)

# License & copyright

 Syed Mohammed Jafary, S.M.J Ltd
 Licensed under the [Apache 2.0 License](LICENSE).