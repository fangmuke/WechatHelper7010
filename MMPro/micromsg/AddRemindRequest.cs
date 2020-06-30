using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "AddRemindRequest")]
	[Serializable]
	public class AddRemindRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private string _ClientID = "";

		private ulong _RemindTime;

		private uint _ToUserCount;

		private readonly List<RemindMember> _ToUserList = new List<RemindMember>();

		private string _Content = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
		public BaseRequest BaseRequest
		{
			get
			{
				return this._BaseRequest;
			}
			set
			{
				this._BaseRequest = value;
			}
		}

		[ProtoMember(2, IsRequired = false, Name = "ClientID", DataFormat = DataFormat.Default), DefaultValue("")]
		public string ClientID
		{
			get
			{
				return this._ClientID;
			}
			set
			{
				this._ClientID = value;
			}
		}

		[ProtoMember(3, IsRequired = true, Name = "RemindTime", DataFormat = DataFormat.TwosComplement)]
		public ulong RemindTime
		{
			get
			{
				return this._RemindTime;
			}
			set
			{
				this._RemindTime = value;
			}
		}

		[ProtoMember(4, IsRequired = true, Name = "ToUserCount", DataFormat = DataFormat.TwosComplement)]
		public uint ToUserCount
		{
			get
			{
				return this._ToUserCount;
			}
			set
			{
				this._ToUserCount = value;
			}
		}

		[ProtoMember(5, Name = "ToUserList", DataFormat = DataFormat.Default)]
		public List<RemindMember> ToUserList
		{
			get
			{
				return this._ToUserList;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "Content", DataFormat = DataFormat.Default), DefaultValue("")]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
