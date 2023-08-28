node {
    stage('Checkout') {
        // Get the code from the version control system.
        checkout scm
    }
    stage('Restore') {
        // Restore any dependencies for the project.
        sh 'dotnet restore'
    }
    stage('Build') {
        // Build the project.
        sh 'dotnet build --configuration Release'
    }
}