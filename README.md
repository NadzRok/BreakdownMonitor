# BreakdownMonitor
This is what I got to for the breakdown monitor, I need to brush up on my react skills, it's been a while since I have used it.
I have ste everything up, THe API is working 100% I have installed swagger so you can test it through swagger or post man if you prefer.
if you have a local sql database, then you just need to use the code first comads(Update-Database), and it should create the database for you, if not a local db then just copy your connection string into the `appsetting.json` of the `BreakdownMonitor.Server` profect and then run the `Update-Database`.
for the front end, I managed to get a list up and running, and it is reading the data, I even get the correct amount of lines of data, I just need to work out why it's not displaying the data, I think I need to spend the next week or brushing up on my react knowledge.
If you are running the project through visual studio and you get the first vite console with no swagger web page, quit that one as it will load it again after the API has been loaded. you can use swagger to test the API and press `o + enter` in the vite consol and it will run the front end, all though there is not much to do there.
