pipeline {
    agent {
        docker { 
            image 'mcr.microsoft.com/dotnet/sdk:6.0' 
        }
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
                sh 'dotnet restore ${workspace}/poc-local-jenkins.sln'
            }
        }
        stage('Build') {
            steps {
                // Build the project.
                sh 'dotnet build ${workspace}/poc-local-jenkins.sln --configuration Release'
            }
        }
    }
}
