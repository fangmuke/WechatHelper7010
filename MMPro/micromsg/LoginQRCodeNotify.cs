using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "LoginQRCodeNotify")]
	[Serializable]
	public class LoginQRCodeNotify : IExtensible
	{
		private string _UUID = "";

		private uint _Status;

		private string _UserName = "";

		private string _Pwd = "";

		private string _HeadImgURL = "";

		private uint _PushLoginURLExpiredTime = 0u;

		private string _NickName = "";

		private uint _ExpiredTime = 0u;

		private string _PairWaitTip = "";

		private uint _AuthorClientVersion = 0u;

		private string _AuthorDeviceType = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = false, Name = "UUID", DataFormat = DataFormat.Default), DefaultValue("")]
		public string UUID
		{
			get
			{
				return this._UUID;
			}
			set
			{
				this._UUID = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public uint Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				this._Status = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "UserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				this._UserName = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "Pwd", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Pwd
		{
			get
			{
				return this._Pwd;
			}
			set
			{
				this._Pwd = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "HeadImgURL", DataFormat = DataFormat.Default), DefaultValue("")]
		public string HeadImgURL
		{
			get
			{
				return this._HeadImgURL;
			}
			set
			{
				this._HeadImgURL = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "PushLoginURLExpiredTime", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint PushLoginURLExpiredTime
		{
			get
			{
				return this._PushLoginURLExpiredTime;
			}
			set
			{
				this._PushLoginURLExpiredTime = value;
			}
		}

		[ProtoMember(7, IsRequired = false, Name = "NickName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string NickName
		{
			get
			{
				return this._NickName;
			}
			set
			{
				this._NickName = value;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "ExpiredTime", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint ExpiredTime
		{
			get
			{
				return this._ExpiredTime;
			}
			set
			{
				this._ExpiredTime = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "PairWaitTip", DataFormat = DataFormat.Default), DefaultValue("")]
		public string PairWaitTip
		{
			get
			{
				return this._PairWaitTip;
			}
			set
			{
				this._PairWaitTip = value;
			}
		}

		[ProtoMember(10, IsRequired = false, Name = "AuthorClientVersion", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint AuthorClientVersion
		{
			get
			{
				return this._AuthorClientVersion;
			}
			set
			{
				this._AuthorClientVersion = value;
			}
		}

		[ProtoMember(11, IsRequired = false, Name = "AuthorDeviceType", DataFormat = DataFormat.Default), DefaultValue("")]
		public string AuthorDeviceType
		{
			get
			{
				return this._AuthorDeviceType;
			}
			set
			{
				this._AuthorDeviceType = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
