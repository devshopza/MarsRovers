# Project Title

Mars Rover Challenge

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install

```
Microsoft Visual Studio 2019 Community
```

### Running the solution

```
* Open the main solution file (MarsRovers.sln) from Microsoft Visual Studio 2019 Community.

* The solution consit of 4 Projects:

* 1 - MarsRovers.Library :: This solution contains all the logic of the challange. (DLL Output) 

* 2 - MarsRovers.UnitTest :: This solution uses NUnit.Framework with Test methods against "Plateau" and "Rover" Classes in MarsRovers.Library 

* 3 - MarsRovers.Console :: This solution is a console app that has a pre-defined samples file (BulkDeploy.txt) and runs as a Batch Command (Multiple Deployment)

* 5 - MarsRovers.WebAPI :: This is a WebAPI with a index.html (UI for deploying rovers) that calls the WebAPI via jQuery.ajax and displayes the "Rover" movement log in a Google Chart - this is the default project
```

## Built With

* [BootStrap](https://getbootstrap.com/) - v4.4.1 :: The style framework used
* [jQuery](https://jquery.com/) - v3.4.1 :: JavaScript library
* [Google Charts](https://developers.google.com/chart)


