# Create an Azure Mobile Apps Instance

## Overview

In this step-by-step exercise, you will create a new **Mobile App** instance using Azure's *App Service*.

## Step-by-Step

- Navigate to <https://tryappservice.azure.com/>
- Select the **Mobile App** app type.
  ![Select Mobile App](../media/08-00_step.png)
- Select the **Todo List** template and click the **Create** button.
  ![Select Todo List](../media/08-01_step.png)
- Sign-in using a social identity to validate that you are a real person.
  ![Sign-in](../media/08-03_step.png)
- You will see a list of options to download template apps. You can safely skip this step.
  ![Template Apps](../media/08-04_step.png)
- Make sure you click the hyperlink to extend your trial from one hour to twenty-four hours.
  ![Extend Trial](../media/08-05_step.png)
- Copy and store your mobile app's url.
  ![Mobile App Url](../media/08-06_step.png)
  > **Example**: https://9bdb3b8d-0ee0-4-231-b9ee.azurewebsites.net/

- Use any HTTP tool to send a *GET* request.
  > Tools include, <http://hurl.it>, *Postman* and *Fiddler*.

- Send a *Get* request to the **tables/TodoItem** resource using your URL as the base Url and adding a single additional header with the key *ZUMO-API-VERSION* and a value of *2.0.0*.
  > **Example**: https://9bdb3b8d-0ee0-4-231-b9ee.azurewebsites.net/tables/TodoItem

  ![Example Request](../media/08-07_step.png)

## Result

  ![Mobile App Url](../media/08_complete.png)
