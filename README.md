# Selenium-automation

Example of web tests automation with Selenium (C#), log4net and Jenkins

## Overview

These tests can be launched via Test explorer, .bat file (you can find it in the root of the project) and via Jenkins job

## Setup in Jenkins

At first download next plugins:
 - MSBuild Plugin
 - File Operations Plugin
 - Git
 - Nunit Plugin

Note: during first job runnings it can be asked for Script approvals (Manage Jenkins -> In-process Script Approval)

After create an empty project on your Jenkins, e.g Release job to get latest changes of your project from Git repository.
In the job configuration you can connect to your github repository with URL and credentials. Credentials can be created in Manage Jenkins -> Manage credentials ->
click on Jenkins link -> click on next link -> see Add credentials button on the left

Also configure your MS Build in two steps:
1. In Manage Jenkins -> Global Tool Configuration -> MSBuild -> Add. Give a name and set path from your machine, e.g. 'C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Current\'
2. In Release job configuration find Build -> Add build step -> Build a Visual Studio project or solution using MSBuild -> Choose MS Build version you created above and set .sln file. For this project - Selenium-automation.sln

Save all changes.

Now you can create job to run tests. During creation choose Pipeline template. In pipeline area you can paste script from Jenkins/Pipeline file or just read from this file using groovy

That's it! Now you can build Release job and your Test job. After see the Test results 
