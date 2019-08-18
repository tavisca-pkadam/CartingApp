pipeline {
    agent any
    parameters {
        string(name: "SolutionPath", defaultValue: "CartingApp.sln"),
        string(name: "TestProjectPath", defaultValue: ""),
        string(name: "DllPath", defaultValue: "")
    }
    stages {
        stage('Build') {
            steps {
                echo 'Restore'
                echo ''
                echo 'Build'
                sh 'dotnet build {SolutionPath}'
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