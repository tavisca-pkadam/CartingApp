pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                echo 'Build'
                sh 'dotnet build CartingApp.sln'
            }
        }
        stage('Test') {
            steps {
                echo 'Test'
                sh 'dotnet test TestCartingApp/TestCartingApp.csproj'
            }
        }
    }
}