## General ##

This documents contains a few notes and links for our external testers.

## Bug Reporting ##

While you can always directly message me or someone else in the team to bring something to our attention, please file every bug in the Issue tracker on our google code page as well:
http://code.google.com/p/project-nevada/issues/list

Otherwise we may lose track of things and bugs end up being overlooked. This Issue Tracker also supports comments, so check your reported issues regularly for status updates or further requests.

Oh, and another important thing: When noticing a bug thats easy to reproduce and that wasn't there before an update, try a clean safe before reporting it. Chances are good that it might be gone then.

## Issue life-cycle ##

Basically it will work like that
1. You report an issue
2. It's confirmed/acknowledged
3. The fix is committed to SVN
4. At some point a new installer package is created from the current SVN snapshot
5. I'll comment on all bugs that should be fixed in this new package
6. You confirm that they are really fixed
7. The issues is closed.

## Readme ##

The most current version of the readme can always be found here:
http://project-nevada.googlecode.com/svn/trunk/FONV%20Modules/Core/readme%20-%20Project%20Nevada.txt

It contains some further information on how certain features are supposed to behave, locations/stats of all implants etc. So this information should be helpful to find specific bugs.

## Which file(s) to test ##

Unless stated otherwise, just grab the packages from the latest revision in the Downloads section, deactivate the old package(s) in FOMM and install the new one(s). Currently this is just a single installer package.

## What to test for ##

There may be times, when we want you to test something specific (which will happen when a new feature is added). However, since of course we test details ourselves as well, things are expected to be more or less functional once they are uploaded/committed.

So to sum things up, there are 2 general things you can always do:
- Just play the game, if possible have fun while doing so, and keep your eyes open for anything worth reporting.
- Try to break stuff, i.e. do unexpected things that could cause features to misbehave.