# Unity - StyleCop Ignore Utility

StyleCop Ignore Utility is a Unity Editor tool we use at [RedBlueGames](http://www.redbluegames.com) to ignore scripts when StyleCop checks for style violations in our projects. This comes in handy in two situations:

* Ignoring third-party Assets (none match our style exactly)
* Ignoring our own test and generated scripts

## What is StyleCop?
If you haven't heard of StyleCop I'd recommend a couple of our blog posts on the topic.

- Why We Adopted StyleCop
- How to Get StyleCop Installed for a Unity Project


## Installation

First you'll need to make sure you have StyleCop installed. See [How to Get StyleCop Installed for a Unity Project](urlhere) for instructions.

- After installing StyleCop you'll need to download and install the latest .unitypackage release from this repository ([link](https://github.com/redbluegames/unity-stylecop-ignoreutility/releases/download/v1.0/StyleCopIgnoreUtility.unitypackage)).
- In _Unity Editor_ go to **Assets** -> **Import Package** -> **Custom Package...**
- Select the .unitypackage file you just downloaded

We generally install all of our plugins under their company folders. So our recommended directory structure for this plugin looks like this.

```
├── Assets
│   ├── RedBlueGames
│   │   ├── StyleCopIgnoreUtility
│   ├── Resources
│   │   ├── RedBlueGames
│   ├── StyleCop.Cache
├── Settings.StyleCop

```

## Using StyleCop Ignore Utility

Once you have finished StyleCop and the Ignore Utility installation, you should have a **Settings.StyleCop** file somewhere in your project, most likely at the root. You can now set up your ignore preferences through our utility.

1. In *Unity Editor* go to **Window** -> **StyleCop Ignore Utility** to open the utility.
1. Point the utility to your Settings.StyleCop file
[screenshot here]
1. Check any folders or files you'd like StyleCop to Ignore
1. Write your changes to the Settings.StyleCop file

That's it! You should now see StyleCop ignore

## How it Works

We leverage the parser settings to ignore files with given names. It uses regular expression rules to filter out files by name. When users select folders, you're actually just adding (or removing) every file in that folder from the list of values inserted into the Settings.StyleCop file.

Here's a diff of the file after adding the IngoredScriptWithErrors to our settings.

```diff
diff --git a/Settings.StyleCop b/Settings.StyleCop

index 0a67b66..a1bf1d8 100644
--- a/Settings.StyleCop
+++ b/Settings.StyleCop
@@ -95,7 +95,9 @@
   <Parsers>
     <Parser ParserId="StyleCop.CSharp.CsParser">
       <ParserSettings>
-        <CollectionProperty Name="GeneratedFileFilters" />
+        <CollectionProperty Name="GeneratedFileFilters">
+          <Value>[^a-z ]IgnoredScriptWithErrors.cs</Value>
+        </CollectionProperty>
       </ParserSettings>
     </Parser>
   </Parsers>
```
