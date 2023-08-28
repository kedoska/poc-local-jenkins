pipeline {
    agent {
        docker { 
            image 'mcr.microsoft.com/dotnet/sdk:6.0' 
        }
    }
    
    environment {
        HOME = '/tmp'
    }

    stages {
        stage('Checkout') {
            steps {
                // Get the code from the version control system.
                checkout scm
            }
        }
        stage('Restore') {
            steps {
                // Restore any dependencies for the project.
                sh 'dotnet restore poc-local-jenkins.sln'
            }
        }
        stage('Build') {
            steps {
                // Build the project.
                sh 'dotnet build poc-local-jenkins.sln --configuration Release'
            }
        }
        
       stage('Test') {
            steps {
                // Run SpecFlow tests
                sh 'dotnet test Example.Domain.Tests/Example.Domain.Tests.csproj --configuration Release'
            }
        }
    }
}
