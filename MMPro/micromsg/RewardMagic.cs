using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "RewardMagic")]
	[Serializable]
	public class RewardMagic : IExtensible
	{
		private string _MagicWord;

		private string _MagicUrl;

		private uint _MagicExpire = 0u;

		private uint _MagicLimit = 0u;

		private string _ProductID;

		private string _Md5 = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "MagicWord", DataFormat = DataFormat.Default)]
		public string MagicWord
		{
			get
			{
				return this._MagicWord;
			}
			set
			{
				this._MagicWord = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "MagicUrl", DataFormat = DataFormat.Default)]
		public string MagicUrl
		{
			get
			{
				return this._MagicUrl;
			}
			set
			{
				this._MagicUrl = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "MagicExpire", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint MagicExpire
		{
			get
			{
				return this._MagicExpire;
			}
			set
			{
				this._MagicExpire = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "MagicLimit", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint MagicLimit
		{
			get
			{
				return this._MagicLimit;
			}
			set
			{
				this._MagicLimit = value;
			}
		}

		[ProtoMember(5, IsRequired = true, Name = "ProductID", DataFormat = DataFormat.Default)]
		public string ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				this._ProductID = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "Md5", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Md5
		{
			get
			{
				return this._Md5;
			}
			set
			{
				this._Md5 = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
