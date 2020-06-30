using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "StatusNotifyRequest")]
	[Serializable]
	public class StatusNotifyRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private uint _Code;

		private string _FromUserName = "";

		private string _ToUserName = "";

		private string _ClientMsgId = "";

		private uint _UnreadChatListCount = 0u;

		private readonly List<StatusNotifyUnreadChat> _UnreadChatList = new List<StatusNotifyUnreadChat>();

		private StatusNotifyFunction _Function = null;

		private uint _UnreadFunctionCount = 0u;

		private readonly List<StatusNotifyFunction> _UnreadFunctionList = new List<StatusNotifyFunction>();

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

		[ProtoMember(2, IsRequired = true, Name = "Code", DataFormat = DataFormat.TwosComplement)]
		public uint Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				this._Code = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "FromUserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string FromUserName
		{
			get
			{
				return this._FromUserName;
			}
			set
			{
				this._FromUserName = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "ToUserName", DataFormat = DataFormat.Default), DefaultValue("")]
		public string ToUserName
		{
			get
			{
				return this._ToUserName;
			}
			set
			{
				this._ToUserName = value;
			}
		}

		[ProtoMember(5, IsRequired = false, Name = "ClientMsgId", DataFormat = DataFormat.Default), DefaultValue("")]
		public string ClientMsgId
		{
			get
			{
				return this._ClientMsgId;
			}
			set
			{
				this._ClientMsgId = value;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "UnreadChatListCount", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint UnreadChatListCount
		{
			get
			{
				return this._UnreadChatListCount;
			}
			set
			{
				this._UnreadChatListCount = value;
			}
		}

		[ProtoMember(7, Name = "UnreadChatList", DataFormat = DataFormat.Default)]
		public List<StatusNotifyUnreadChat> UnreadChatList
		{
			get
			{
				return this._UnreadChatList;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "Function", DataFormat = DataFormat.Default), DefaultValue(null)]
		public StatusNotifyFunction Function
		{
			get
			{
				return this._Function;
			}
			set
			{
				this._Function = value;
			}
		}

		[ProtoMember(9, IsRequired = false, Name = "UnreadFunctionCount", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint UnreadFunctionCount
		{
			get
			{
				return this._UnreadFunctionCount;
			}
			set
			{
				this._UnreadFunctionCount = value;
			}
		}

		[ProtoMember(10, Name = "UnreadFunctionList", DataFormat = DataFormat.Default)]
		public List<StatusNotifyFunction> UnreadFunctionList
		{
			get
			{
				return this._UnreadFunctionList;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
