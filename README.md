# Etch.OrchardCore.News

Module for [Orchard Core](https://github.com/OrchardCMS/OrchardCore) that provides a good starting place for editing & displaying news content.

## Build Status

[![Build Status](https://secure.travis-ci.org/etchuk/Etch.OrchardCore.News.png?branch=master)](http://travis-ci.org/etchuk/Etch.OrchardCore.News) [![NuGet](https://img.shields.io/nuget/v/Etch.OrchardCore.News.svg)](https://www.nuget.org/packages/Etch.OrchardCore.News)

## Orchard Core Reference

This module is referencing a stable build of Orchard Core ([`1.4.0`](https://www.nuget.org/packages/OrchardCore.Module.Targets/1.4.0)).

## Installing

This module is available on [NuGet](https://www.nuget.org/packages/Etch.OrchardCore.News/). Add a reference to your Orchard Core web project via the NuGet package manager. Search for "Etch.OrchardCore.News", ensuring include prereleases is checked.

Alternatively you can [download the source](https://github.com/etchuk/Etch.OrchardCore.News/archive/master.zip) or clone the repository to your local machine. Add the project to your solution that contains an Orchard Core project and add a reference to Etch.OrchardCore.News.

## Usage

Enabling the "News" feature will automatically set up a good starting place for managing news content.

### Content Definitions

Creates a "News Post" content type. "News Post" is configured to have various fields that would commonly be found on a news article (e.g. Author, Tags, Related News) as well as using [our block editor](https://github.com/etchuk/Etch.OrchardCore.Blocks) to curate the content for the article.

### Tags

"News Post" contains a taxonomy field that is linked to a "Tags" taxonomy configured to use a "Tag" content type.

### Example Content

This is not created by default, however a recipe for creating an example news post is available and can be run via the admin dashboard ("Settings" -> "Recipes").
