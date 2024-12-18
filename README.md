<!-- <p align="center">
  <a alt="Travel Ease logo" href="#"><img src="./docs/img/logo.svg"  width="200px"></a>
</p> -->

<h1 align="center">Very Short - link shortener</h1>
<!-- <p align="center">The easiest way to plan your travel!</p> -->
<br>

<p align="center">
  <!-- license -->
  <img alt="License" src="https://img.shields.io/github/license/VenicioAugusto/vs-link-shortener?color=cb4c83">
  <!-- commits per month -->
  <img alt="Commits per month" src="https://img.shields.io/github/commit-activity/m/VenicioAugusto/vs-link-shortener?color=574ccb">
  <!-- languages -->
  <img alt="GitHub language count" src="https://img.shields.io/github/languages/count/VenicioAugusto/vs-link-shortener?color=CB504C">
  <!-- top language-->
  <img alt="Top language" src="https://img.shields.io/github/languages/top/VenicioAugusto/vs-link-shortener?color=cb744c">
</p>
<br>

<!-- TABLE OF CONTENTS -->
<p align="center">
  <a href="#-about-the-project">About the project</a> •
  <a href="#-features">Features</a> •
  <!-- <a href="#-roadmap">Roadmap</a> • -->
  <!-- <a href="#-getting-started">Getting started</a> • -->
  <a href="#-license">License</a> •
  <a href="#-tech">Technical documentation</a>
</p>

## 💻 About the project

Very Short - link shortener is an application that allows user to shorten links.
The core of the project is that users will be able to enter the website, paste a link they want to shorten, and the website will return a smaller link that will take them to the same page. That link can be shared as many times as the user wants.

<img alt="Travel Ease " src="./docs/img/project.png" width="700px">

### Built with

This project is made with C#, using [ASP.NET][aspnet] for the backend, and with JavaScript, using [React][react], for the frontend.
technologies:

<!-- - [Storybook][storybook] for developing the UI components in isolation. -->
<!-- - [Styled Components][styled] for styling the React components. -->
- [Jest][jest] as the chosen testing framework.
- [React Testing Library][rtl] for testing utilities.
- [MongoDB][mongo] as the preferred NoSQL database solution.
- [Docker][docker] for containerizing the application.
<!-- - [Terraform][terraform] for provisioning the Azure WebApp infrastructure. -->
- [GitHub Actions][actions] for CI/CD integration.

## 🎨 Features

In the version 1 (V1) of the project, it is possible to:

- [x] Paste a link and receive a shortened version that will take to the same page.
- [x] Create a user profile that will let store up to 5 links.
- [x] Use the website in both mobile and desktop.

<!-- ## 🎯 Roadmap

### Version 1 (V1)

- **Backend Get**: Backend serving a JSON file.
- **Backend Post**: Backend receiving a JSON file and saving it at the database.
- **Login system**: Authentication system.

### Version 2 (V2)

- **Frontend Get**: Frontend working with a received JSON file.
- **Frontend Post**: Frontend working serving a JSON file.

### Version 3 (V3)

- **Visual Improvements**: Adjust any visuals to be responsive for both mobile and desktop.

### Version 4 (V4)

- **Extensions**: Turn the application into a web extension. -->

<!-- - **Tag Expansion**: Users will have more tags to broaden search criteria options.
- **Departure City**: Users will have the option to specify their departure city.
- **Departure Date**: Users will be able to select their desired departure date.
- **Currency Selection**: Users will be able to choose their preferred currency for pricing.
- **Real Data Integration**: Integration with real-world data will enhance the authenticity of information.
- **Login and Sign-Up Options**: Users will have the convenience of logging in or signing up using Microsoft or Google providers.

### Version 3 (V3)

- **Favorite Places**: Users will have the ability to save their favorite travel destinations.
- **Home Recommendations**: Recommendations will be provided based on saved favorite places.
- **Hotel and Flight Filters**:
  - **Hotel**:
    - Reviews
    - Distance from downtown
    - Breakfast availability
    - Price range
    - Amenities
  - **Flight**:
    - Number of stops
    - Cabin class
    - Airline preference
    - Departure and arrival times
    - Baggage allowance

### Version 4 (V4)

- **Login and Registration without Providers**: Users will have the option for custom login and registration directly within the application.
- **Account Settings**: Users will have access to account settings for managing preferences and personal information.
- **Round Trip or One-Way Trip**: Users will be able to specify whether their trip is a round trip or one-way.
- **Expanded Hotel and Flight Filters**: Enhancements will be implemented to offer users more sophisticated filtering options for hotels and flights. -->

## 🏁 Getting started
<!-- 
### Prerequisites

Before setting up the project locally, ensure you have the following prerequisites ready:

1. **Node.js 20+**: Install Node.js version 20 or later. You can download and install Node.js from [here][node].

2. **MongoDB Database Tools**: Install MongoDB Database Tools to use the same mocked data without issues. Installation instructions can be found [here][mongotools].

3. **MongoDB Atlas Account**: Sign up for a MongoDB Atlas account to host the database. You can create an account [here][atlas].

If you plan to deploy it on the cloud, you'll need:

1. **Terraform**: Ensure you have Terraform installed on your machine. If not, you can download and install it from [here][terraformcli].

2. **Azure CLI**: Install the Azure CLI to interact with Azure services from the command line. Installation instructions can be found [here][azurecli].

3. **Docker Hub Account**: You'll need a Docker Hub account for containerization. Sign up for an account [here][hub].

4. **Azure Account**: You'll require an Azure account for provisioning resources. Sign up for free [here][azure].

5. **Extra**: You'll need to create and store the necessary secrets and environment variables on your GitHub and update the [GitHub workflow](./.github/workflows/main_sastravelplanner.yml) if necessary. For more information, see [this documentation][secrets].

Once you have all these pieces in place, you can proceed with setting up the project locally.

### Installation

In order to run the project locally, follow these steps:

1. Clone the repository.

```bash
git clone https://github.com/your-username/project-name.git
```

Replace `your-username` with your GitHub username and `project-name` with the name of the project.

2. Change into the project directory:

```bash
cd <project-name>
```

3. Install the project dependencies using npm:

```bash
npm install
```

4. Set up the database:

a. Run Prisma migration to create database schema:

```bash
npx prisma db push
```

b. Import mock data into the database (replace `<DATABASE_URL>` and `<collection-name>` accordingly):

```bash
mongoimport --uri <DATABASE_URL> --collection <collection-name> --drop --file ./src/lib/db/mocks/<collection-name>-data.json
```

5. View the application

Open your web browser and navigate to `http://localhost:3000` to view the application running locally.

You are now ready to start working on the project locally! 😊 -->

## 📃 License

Distributed under the MIT License. See [LICENSE](./LICENSE) for more information.

---

## 🌟 Technical documentation

For more details about the technical roadmap, see the [technical documentation](./docs/README.md).

<!-- LINKS-->

<!-- [travelease]: https://sastravelplanner.azurewebsites.net/
[next]: https://nextjs.org/
[storybook]: https://storybook.js.org/
[styled]: https://styled-components.com/
[jest]: https://jestjs.io/
[rtl]: https://testing-library.com/
[prisma]: https://www.prisma.io/
[mongo]: https://www.mongodb.com/
[docker]: https://www.docker.com/
[terraform]: https://www.terraform.io/
[actions]: https://docs.github.com/en/actions
[node]: https://nodejs.org/
[mongotools]: https://www.mongodb.com/docs/database-tools/
[atlas]: https://www.mongodb.com/cloud/atlas
[hub]: https://hub.docker.com/
[azure]: https://azure.microsoft.com/
[terraformcli]: https://www.terraform.io/downloads.html
[azurecli]: https://docs.microsoft.com/en-us/cli/azure/install-azure-cli
[secrets]: https://docs.github.com/en/actions/security-guides/using-secrets-in-github-actions -->