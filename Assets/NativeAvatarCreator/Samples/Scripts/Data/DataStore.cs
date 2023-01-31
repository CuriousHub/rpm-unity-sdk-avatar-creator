﻿using NativeAvatarCreator;
using UnityEngine;

namespace AvatarCreatorExample
{
    public class DataStore : MonoBehaviour
    {
        public UserSession User;
        public AvatarProperties AvatarProperties;

        public void Awake()
        {
            AvatarProperties = new AvatarProperties();
        }
    }
}
