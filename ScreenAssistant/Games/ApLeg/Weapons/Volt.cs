﻿namespace TiqSoft.ScreenAssistant.Games.ApLeg.Weapons
{
    internal sealed class Volt : UniqueLogicWeapon
    {
        public Volt(string name, double burstSeconds, string recognizedName, int numOfMods) 
            : base(name, burstSeconds, recognizedName, numOfMods)
        {
        }

        public override double AdjustMouse(int shotNumber)
        {
            this.AdjustmentCoefficient = CalculateAdjustment(shotNumber, 16);
            var horizontalOffset = Rnd.NextDouble() * 1;
            var verticalOffset = Rnd.NextDouble() + 8.5;
            this.MoveMouse(horizontalOffset, verticalOffset);

            return this.GetAdjustmentTime(1d);
        }
    }
}