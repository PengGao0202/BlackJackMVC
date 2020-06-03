#pragma checksum "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bae0075a5ad181d8a337670ed7f1af2bf5470773"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\_ViewImports.cshtml"
using BlackJackMVC;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\_ViewImports.cshtml"
using BlackJackMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae0075a5ad181d8a337670ed7f1af2bf5470773", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5aed5e0f9c595474d4328704791546f86957025", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
#line 4 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(63, 20, true);
            WriteLiteral(" the game</h2>\r\n<h3>");
            EndContext();
            BeginContext(84, 19, false);
#line 5 "C:\Users\LENOVO\source\repos\BlackJackMVC\BlackJackMVC\Views\Home\About.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(103, 3260, true);
            WriteLiteral(@"</h3>
<h3>Blackjack (21) - Final Project</h3>
<p>
    Implement a program that plays the game of Blackjack. The user will be the single player in the game,
    and the computer will be the dealer. Use the game rules specified below. The purpose of this project
    is to demonstrate your logic and programming skills, and is not intended to endorse any form of gambling
    whatsoever, legal or otherwise.
</p>
<h4>Rules of the Game</h4>
<h4>Basics</h4>
<p>
    The player competes against the dealer. The objective of the game is to have a higher point total
    than the dealer without going over 21. 
</p>
<p>
    Each ace counts as either 1 point or 11 points, face cards (kings, queens, jacks) count 10 points each,
    and all other cards (2 through 9) count their face value. This blackjack game will be played with a single
    deck of 52 cards at a time.
</p>
<h4>Betting</h4>
<p>
    Before the deal, the player places a bet. The player may bet any amount from $1 to $100. When a player's
   ");
            WriteLiteral(@" bank account is zero or negative the game is over. The player starts the game with $500. Of course, we are
    dealing with only imaginary money for this project.
</p>
<h4>Game Play</h4>
<p>
    At the beginning of each game the cards are shuffled. At the beginning of each hand, the dealer deals two
    cards to the player and two cards to himself. The player's cards are dealt face up, while one of the dealer's
    cards is dealt face up and the other is face down. After the deal, the dealer asks the player whether they
    want an additional card. The player may ""Stand"" -- play just the two cards originally dealt or may ""Hit""--
    take another card. After being dealt an additional card, the player may stop or may take still another card.
    A player may take as many cards as they want, but as soon as the player's total equals or exceeds 21, the game is over.
    If the players total exceeds 21 then the player loses -- regardless of what the dealer has. If the players hand equals 21,
    then t");
            WriteLiteral(@"he player has won (unless the dealers total is also 21). After the player stands, the dealer's remaining card is exposed.
</p>
<h4>The dealer must then hit or stand according to these rules:</h4>
<p>1. The dealer must count an ace as 11 points, unless this causes the dealer to bust. Then the dealer must count the ace as 1 point.</p>
<p>2. If the dealer has a total of 17 points or more, he must stand.</p>
<p>
    3. If the dealer has a total of less than 17 points, he must hit. If the dealer ""busts"" by going over 21, the player wins.
    In case of a tie (known as a push), the player's bet is returned (no money changes hands). If a player's or the dealer's first
    two cards total 21 (an ace and a 10 or face card), the holding is known as a blackjack. A player with blackjack is paid extra --
    one-and-a-half times the original bet -- unless the dealer also has blackjack, in which case the player loses. The player may
    leave the game between any hands. This version of blackjack will not implemen");
            WriteLiteral("t rules for doubling down, splitting, or insurance.\r\n</p>\r\n<p>Make sure that your project can run as a standalone project (including the card images).</p>\r\n<p>Good luck and have fun!</p>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
