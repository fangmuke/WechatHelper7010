using ProtoBuf;
using System;
using System.Collections.Generic;

namespace micromsg
{
	[ProtoContract(Name = "AddContactLabelResponse")]
	[Serializable]
	public class AddContactLabelResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private uint _LabelCount;

		private readonly List<LabelPair> _LabelPairList = new List<LabelPair>();

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "LabelCount", DataFormat = DataFormat.TwosComplement)]
		public uint LabelCount
		{
			get
			{
				return this._LabelCount;
			}
			set
			{
				this._LabelCount = value;
			}
		}

		[ProtoMember(3, Name = "LabelPairList", DataFormat = DataFormat.Default)]
		public List<LabelPair> LabelPairList
		{
			get
			{
				return this._LabelPairList;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
