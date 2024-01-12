using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using StudentFD.SOM;
using StudentFD;

namespace StudentFD
{
	public class CTokenGuy : Racon.CGenericFederate
    {
		public string TID;
		public int TokensToGive;

        public SOM.FederateSom Som;

        public CTokenGuy()
		{
			TID = "1";
            Random rnd = new Random();
            TokensToGive = rnd.Next(1, 21); //tokens given generated randomly for ease, a token guy can at max. give 20 tokens

        }
        
		public bool tokensGiven(int tokensNeeded)
		{
			if (tokensNeeded <= TokensToGive) {
                HlaInteraction interaction = new HlaInteraction(Som.TokenInteractionIC, "TokenInteraction");
                TokensToGive = TokensToGive - tokensNeeded;

                // Add Values
                interaction.AddParameterValue(Som.TokenInteractionIC.giveOrTake, 0); // int
                interaction.AddParameterValue(Som.TokenInteractionIC.message, "Tokens needed are given"); // String
                interaction.AddParameterValue(Som.TokenInteractionIC.amount, tokensNeeded); // int


                // Send interaction
                return (SendInteraction(interaction, "Tokens needed are given"));
            }
			else
			{
                HlaInteraction interaction = new Racon.RtiLayer.HlaInteraction(Som.TokenInteractionIC, "TokenInteraction");

                // Add Values
                interaction.AddParameterValue(Som.TokenInteractionIC.giveOrTake, 0); // int
                interaction.AddParameterValue(Som.TokenInteractionIC.message, "Do not have this amount now,  I will talk with the company"); // String
                interaction.AddParameterValue(Som.TokenInteractionIC.amount, tokensNeeded); // int

                Random rnd = new Random();
                TokensToGive = rnd.Next(1, 21); // generating new amount
                // Send interaction
                return (SendInteraction(interaction, "Do not have this amount yet, I will talk with the company"));
            }
		}
	}
}
