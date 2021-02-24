# Introduction

Mars Rover is a Blazor web application that allows the user to view photos taken by the Curiosity, Opportunity, and Spirit rovers. It makes use of the public API NASA makes available (see https://api.nasa.gov/).

## Set up

Before attempting to run the application, you need to have a key - go the the site listed above, fill in your details and NASA will email you it. Once you have the key, open the MarsRover.sln in Visual Studio 2019 and open the appsettings.json file in the wwwroot folder. 

```json 
{
  "Configuration": {
    "ApiKey": "<enter api key>",
    "ApiBaseUrl": "https://api.nasa.gov/mars-photos/api/v1"
  }
}
```

Replace the '<enter api key>' text with your key.

## Running

Build and run the app - you will be presented with a screen

![](./Images/2021-01-05-13-59-48.png)

The rover dropdown allows you to select from different Rovers - you can cycle through through the Sol days that the pictures were taken on as well as selected different cameras from the drop down. Pressing Get Photos will retrieve the photos taken on that day for that camera:

![](./Images/2021-01-05-13-59-47.png)



## Contributing
Pull requests are welcome. 

## License
[MIT](https://choosealicense.com/licenses/mit/)
