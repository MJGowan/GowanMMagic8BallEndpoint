/*Madeline Gowan
10-27-2022
Magic 8 Ball - Endpoint
This program should generate a random statement that can answer a question from the user.

Peer review: Jasmine Leek - code works great, the cheat sheet in the notes is such a smart/helpful choice for the user, funny messages too. Nice work!
*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMMagic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MagicController : ControllerBase
{
    Random rnd = new Random();
    //cheat sheet: https://localhost:xxxx/Magic/Ask
    [HttpGet]
    [Route ("Ask")]
    public string Ask(){
    string[] pickRandom = {"This sounds like a personal problem.", "The magic 8 ball is busy right now, try again later", "I think you already know the answer", "Yes! Yes. Absolutely, 100%, yes", "Maybe..?", "Oh heck no, nuh-uh", "Are you really asking a BALL for answers? Come on dude.", "...Oh, huh? Sorry I wasn't paying attention, try again", "To be honest I have no idea", "Uhhhh.. please leave a message after the beep. Beeeeeeeep"};
        int index = rnd.Next(pickRandom.Length);
        return (pickRandom[index]);

    }

}