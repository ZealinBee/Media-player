# Introduction

This project uses C# to create a media player console app that allows the user to play, pause, stop and seek audio. The user also has the capability to make a playlist and adding media. This is a project that helps me to learn basic design patterns and best practices. It follows the SOLID principle and implements the observer and singleton pattern.

## Table of Content

- [Technologies](#technologies)
- [Project Structure](#project-strucutre)
- [Getting Started](#getting-started)

## Technologies

- C#

## Project Structure

```
├───Controllers
│       ErrorHandler.cs
│
├───Core
│   ├───Entity
│   │       Audio.cs
│   │       AudioPlayer.cs
│   │       Playlist.cs
│   │       Video.cs
│   │       VideoPlayer.cs
│   │
│   ├───Interfaces
│   │       IMedia.cs
│   │       IMediaPlayer.cs
│   │       IObserver.cs
│   │
│   └───Observer
│           PlayerObserver.cs
│
├───Presentation
│       Program.cs
│
└───Services
        MediaLibrary.cs
        MediaPlayerFactory.cs
        MediaPlayerManager.cs

```

## Getting Started

Clone the repository from github with `git clone`  
Run the code with `dotnet run`
