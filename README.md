# Etch.OrchardCore.News

Module for [Orchard Core](https://github.com/OrchardCMS/OrchardCore) that provides a good starting place for editing & displaying news content.

## Build Status

[![Build Status](https://secure.travis-ci.org/etchuk/Etch.OrchardCore.News.png?branch=master)](http://travis-ci.org/etchuk/Etch.OrchardCore.News)

## Orchard Core Reference

This module is referencing the RC2 build of Orchard Core ([`1.0.0-rc2-13450`](https://www.nuget.org/packages/OrchardCore.Module.Targets/1.0.0-rc2-13450)).

## Installing

This module is currently not available on NuGet but you can [download the source](https://github.com/etchuk/Etch.OrchardCore.Fields/archive/master.zip) or clone the repository to your local machine. Add the project to your solution that contains an Orchard Core project and add a reference to Etch.OrchardCore.News.

## Usage

Enabling the "News" feature will automatically set up a good starting place for managing news content.

### Content Definitions

Creates a "News" & "News Post" content type where "News" uses a `ListPart` to contain a collection of news posts. "News Post" is configured to have various fields that would commonly be found on a news article (e.g. Author, Tags, Related News) as well as using [our block editor](https://github.com/etchuk/Etch.OrchardCore.Blocks) to curate the content for the article.

As part of the set up, a "News" content item will be created, which can be accessed via `/news`.

### Admin Menu

To make it easier for content editors to add a "News Post", a "News" admin menu option is configured, which when selected will take the user to the "News" content item that was created listing any associated news posts.

### Tags

"News Post" contains a taxonomy field that is linked to a "Tags" taxonomy configured to use a "Tag" content type.

### Example Post

This is not created by default, however a recipe for creating an example news post is available and can be run via the admin dashboard ("Settings" -> "Recipes").