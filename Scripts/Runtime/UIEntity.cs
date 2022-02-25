using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AudioBox.UI
{
	public class UIEntity : UIBehaviour
	{
		public RectTransform RectTransform
		{
			get
			{
				if ((object)m_RectTransform == null)
					m_RectTransform = GetComponent<RectTransform>();
				return m_RectTransform;
			}
		}

		[NonSerialized] RectTransform m_RectTransform;

		public Rect GetWorldRect()
		{
			Rect rect = RectTransform.rect;
			return new Rect(
				RectTransform.TransformPoint(rect.position),
				RectTransform.TransformVector(rect.size)
			);
		}

		public Rect GetLocalRect()
		{
			return RectTransform.rect;
		}

		public void BringToFront()
		{
			RectTransform.SetAsLastSibling();
		}

		public void BringToBack()
		{
			RectTransform.SetAsFirstSibling();
		}
	}
}