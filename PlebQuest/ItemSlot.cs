using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    [Flags]
    public enum ItemSlot
    {
        None = 0,
        Neck = 1 << 0,
        Head = 1 << 1,
        Torso = 1 << 2,
        LeftHand = 1 << 3,
        RightHand = 1 << 4,
        LeftFoot = 1 << 5,
        RightFoot = 1 << 6,
        Legs = 1 << 7,
        LeftThumb = 1 << 8,
        LeftIndex = 1 << 9,
        LeftMiddleFinger = 1 << 10,
        LeftRingFinger = 1 << 11,
        LeftPinky = 1 << 12,
        RightThumb = 1 << 13,
        RightIndex = 1 << 14,
        RightMiddleFinger = 1 << 15,
        RightRingFinger = 1 << 16,
        RightPinky = 1 << 17,
        Eyes = 1 << 18,
        Nose = 1 << 19,
        Ears = 1 << 20,
        RightArm = 1 << 21,
        LeftArm = 1 << 22
    }
}
