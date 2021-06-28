# iw4x-server-launcher
A launcher for iw4x to simplify dedicated and party servers used to lobbies

![Capture](https://user-images.githubusercontent.com/86622355/123683559-a575b180-d84c-11eb-8b56-5bbd3652dba2.PNG)

This exists to solve a simple issue. How do I create a lobby server with rotating maps, similar to the original find game option, but in iw4x?"

Well, the answer is a party server which is natively supported by iw4x. Seems the guys at [xLabs](https://xlabs.dev/) thought of everything.

How do I create a party server I hear you asking? Well, you create one by copying a party server template, adding it into your userraw folder and launching the iw4x.exe with a .bat file or shortcut with launch options like -dedicated +set sv_lanonly 1 +set party_enable 1 +playlist your_playlist_file.info etc...

But that's annoying, and getting everyone at a LAN (Especially that one guy that plays on a laptop that doesn't know what an IP is) to do the same thing can kill the mood.

So this launcher is supposed to simplify things to some degree. You copy the launcher and its required playlist files into your game folder, open it, select game mode, launch a party server, open everyones games and join into it just like any other server. When you join you will be thrown into a lobby instead of a match.

If you don't have enough players, you can alt+tab out to the dedicated server you openned earlier and type "xpartygo" in it to force the game to start.

A bots mod by the amazing [inneedbots dev](https://github.com/ineedbots/iw4x_bot_warfare) has also been added into the release to pad out servers or to play on your own.
I recommend going to grab the latest version of that mod before playing because there are improvements to it all the time.

Feel free to open userraw/partyserver.cfg and userraw/server.cfg files and tinker with the settings. What's there will get you going, but you'll probably want to change things to fit your situation.
