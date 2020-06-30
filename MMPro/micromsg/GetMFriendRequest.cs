using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "GetMFriendRequest")]
	[Serializable]
	public class GetMFriendRequest : IExtensible
	{
		private BaseRequest _BaseRequest;

		private uint _OpType = 0u;

		private string _MD5 = "";

		private int _UpdateMobileListSize = 0;

		private readonly List<Mobile> _UpdateMobileList = new List<Mobile>();

		private int _UpdateEmailListSize = 0;

		private readonly List<MEmail> _UpdateEmailList = new List<MEmail>();

		private uint _Scene = 0u;

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

		[ProtoMember(2, IsRequired = false, Name = "OpType", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint OpType
		{
			get
			{
				return this._OpType;
			}
			set
			{
				this._OpType = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "MD5", DataFormat = DataFormat.Default), DefaultValue("")]
		public string MD5
		{
			get
			{
				return this._MD5;
			}
			set
			{
				this._MD5 = value;
			}
		}

		[ProtoMember(4, IsRequired = false, Name = "UpdateMobileListSize", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int UpdateMobileListSize
		{
			get
			{
				return this._UpdateMobileListSize;
			}
			set
			{
				this._UpdateMobileListSize = value;
			}
		}

		[ProtoMember(5, Name = "UpdateMobileList", DataFormat = DataFormat.Default)]
		public List<Mobile> UpdateMobileList
		{
			get
			{
				return this._UpdateMobileList;
			}
		}

		[ProtoMember(6, IsRequired = false, Name = "UpdateEmailListSize", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int UpdateEmailListSize
		{
			get
			{
				return this._UpdateEmailListSize;
			}
			set
			{
				this._UpdateEmailListSize = value;
			}
		}

		[ProtoMember(7, Name = "UpdateEmailList", DataFormat = DataFormat.Default)]
		public List<MEmail> UpdateEmailList
		{
			get
			{
				return this._UpdateEmailList;
			}
		}

		[ProtoMember(8, IsRequired = false, Name = "Scene", DataFormat = DataFormat.TwosComplement), DefaultValue(0L)]
		public uint Scene
		{
			get
			{
				return this._Scene;
			}
			set
			{
				this._Scene = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
