﻿using System.Collections.Generic;
using ConsoleChessGame.Enums;

namespace ConsoleChessGame.Piece
{
    public class Rook : Piece
    {
        public Rook(Color color) : base(color)
        {
        }
        public override bool PotentialMove(Status status, int target)
        {
            throw new System.NotImplementedException();
        }

        public override List<int> PotentialMoveList(Status status, int target)
        {
            throw new System.NotImplementedException();
        }

        public override bool PotentialAttack(Status status, int target)
        {
            throw new System.NotImplementedException();
        }

        public override List<int> PotentialAttackList(Status status, int target)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return Color == Color.Black ? "r" : "R";
        }
    }
}