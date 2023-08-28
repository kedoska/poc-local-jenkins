# PoC for Local Jenkins with .NET Core 6.0 and SpecFlow

## Introduction

This Proof of Concept (PoC) focuses on setting up a local Jenkins infrastructure for experimenting with multi-branch pipelines, .NET Core 6.0, and SpecFlow. The intent is to emphasize learning how to build CI/CD pipelines, utilize SpecFlow for testing, and become acquainted with tools that can make software engineering more practical.

## Prerequisites

- Docker installed on your machine
- .NET Core 6.0 SDK
- Jenkins (Local setup)

## Getting Started

1. **Clone the Repository**: Clone this repository to your local machine.
2. **Start Jenkins**: Follow the [official Jenkins guide](https://www.jenkins.io/doc/book/installing/docker/) to set up a local Jenkins instance using Docker.
3. **Load Jenkinsfile**: Place the `Jenkinsfile` in the root directory of your project.
4. **Run the Pipeline**: Trigger the Jenkins pipeline manually or configure it to run automatically when code is pushed.

## Jenkinsfile Overview

- **Checkout Stage**: Checks out the source code from the repository.
- **Restore Stage**: Restores any NuGet dependencies.
- **Build Stage**: Compiles the .NET Core project.
- **Test Stage**: Runs the SpecFlow tests.

## Learning Objectives

### CI/CD

Continuous Integration and Continuous Deployment (CI/CD) are essential practices in modern software engineering. They help in automating the testing and deployment phases, making the development process more streamlined.

### SpecFlow

SpecFlow is a tool for writing human-readable descriptions of software behaviors without detailing how that functionality is implemented. It enables you to write automated tests in Gherkin language and execute them using MSTest, NUnit, xUnit, and MbUnit.

### Practical Software Engineering Tools

Understanding how to configure and use tools like Jenkins, Docker, and SpecFlow can substantially improve the practical aspects of software engineering, making the process more efficient and effective.

## Conclusion

This PoC serves as a practical guide to set up a local Jenkins environment for CI/CD, particularly focusing on .NET Core 6.0 and SpecFlow testing. Feel free to experiment, extend, and adapt this setup to fit your specific needs.
