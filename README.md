# 0-Day-To-Die
0 Day Exploit Within 7 Days To Die. This exploit allows you to wipe user saved data, Prevent players playing on a server and all around just destroy everyone's progress on a server.<br>
Credits to [Elijah](https://github.com/ElijahDD) for the help. 
## Images
<p align="left">
  <img src="./Images/1.png"
    style="width: 85%;" />
</p>
<p align="left">
  <img src="./Images/2.png"
    style="width: 85%;" />
</p>
<p align="left">
  <img src="./Images/4.jpg"
    style="width: 85%;" />
</p>
<p align="left">
  <img src="./Images/3.png"
    style="width: 35%;" />
</p>

## Explanation
This exploit works through the simple issue of all packets being managed by the entityid. We set the entityid of the player to other players and then when we send packets the server reads the entityid and asigns the data to the player. Which means what happens to one player happens to the other on the server.<br>
Setting entityid to each player means that if you do something like send a movement packet it will desync every player's movement, if you send a teleport packet it will teleport every user, if you die, everyone dies on the server wiping their inventories. Just setting your id to another player will reset all their stats and inventory on the server. Doing this and then utilizing a kill everyone exploit such as in my [7DTD Project](https://github.com/IntelSDM/7DTD) then you can reset everyone's data to your data. <br>
Additionally if you kill all players except yourself while spoofing ids then no one can respawn. everyone will be stuck eternally loading as they already exist on the server. Therefore allowing you to completely kill anyone on the server from playing and holding the server hostage.<br><br>
This simple exploit on how entityids are managed on the server allows you to destroy any server you want.

## Solution
The game itself is a mess, 90% of the code is probably from 2010. The quick fix is to just prevent the entityId from being networked from one client to another but at the same time it wouldn't be hard to brute force it. Ideally you want to move to the id to be a random hashed string to prevent brute forcing (as well as not networking the id).<br>
That still doesn't solve the underlying issues. The real issue is that the server isn't correctly handling clients. Each client should be handled in their own clientserver class which can interface with the socket for that client. Then the serverclient can only listen to requests from its own socket therefore other people can't send false information pretending to be that client as that serverclient instance is only listening for the client connected to their socket. 
