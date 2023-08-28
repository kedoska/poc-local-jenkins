pipeline {
    agent none

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
                sh 'dotnet restore'
            }
        }
        stage('Build') {
            steps {
                // Build the project.
                sh 'dotnet build --configuration Release'
            }
        }
    }
}
