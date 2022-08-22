using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RoomEscape
{
    public class Door : SceneObject
    {
        Transform _doorPanelTrans;
        [SerializeField]bool _opened = false;


        protected override void Start()
        {
            base.Start();


            _doorPanelTrans = transform.Find("StealDoor");


            _opened = false;
        }


        protected override void OnMouseDown()
        {
            base.OnMouseDown();

            // ���� ���� �ݰ�


            if (_opened == false) // ���� ����������, ����
            {
                Open();
            }
            else if (_opened) // ���� ����������, �ݰ�
            {
                Close();
            }

        }

        public void Open()
        {
            _opened = true;

            _doorPanelTrans = transform.Find("StealDoor");

            float x = _doorPanelTrans.localPosition.x;
            float y = _doorPanelTrans.localPosition.y;
            float z = _doorPanelTrans.localPosition.z;

            _doorPanelTrans.localPosition = new Vector3(x, y, z);
            _doorPanelTrans.rotation = Quaternion.Euler(0, 40, 0);

        }

        public void Close()
        {
            _opened = false;

            _doorPanelTrans = transform.Find("StealDoor");

            float x = _doorPanelTrans.localPosition.x;
            float y = _doorPanelTrans.localPosition.y;
            float z = _doorPanelTrans.localPosition.z;

            _doorPanelTrans.localPosition = new Vector3(x, y, z);
            _doorPanelTrans.rotation = Quaternion.Euler(0, 90, 0);
        }

    }
}
