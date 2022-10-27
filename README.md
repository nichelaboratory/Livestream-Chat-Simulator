Livestream Chat Simulator
=========================

Want to livestream on Youtube or Twitch but don't have any followers? Don't worry - download this simple fake chat simulator
and run it in Visual Studio 2019 or more recent. It gives you a scrolling chat window that appears you have hundreds of adoring followers!

Front end: Vue.js and CSS
Back end: .NET Core

How to get it up and running:

<ul>
<li>Download Visual Studio if you don't have it.</li>
<li>Download this source code, open the .SLN file in Visual Studio and start the application (F5).</li>
<li>The code should run in a browser window at the address https://localhost:44378/</li>
<li>While the code is running point your OBS or other streaming software's chat window to the above URL.</li>
<li>Customise the fonts/colours by editing wwwroot/css/site.css</li>
<li>Influence the topics the bots talk about by editing Views/Home/index.cshtml (the 'this.doSearch' line)</li>
<li>Edit Classes/RandomData.cs to add in more topics</li>
<li>Lists of emoji character codes here: https://www.w3schools.com/html/html_emojis.asp and https://www.w3schools.com/charsets/ref_emoji.asp</li>
</ul>

Let me know if you would like any features added to a future version.
I'll also see if I can enhance it to make the appearance of your adoring fans sending in donations!

See my Coding with Brett Youtube Channel for a demo of it in action: <a href="http://www.youtube.com/channel/UCqn4BMeFs2dT6Xz5OUnNSnA">http://www.youtube.com/channel/UCqn4BMeFs2dT6Xz5OUnNSnA</a>

Brett B.
