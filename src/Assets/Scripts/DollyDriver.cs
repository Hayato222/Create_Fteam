using UnityEngine;
using Cinemachine;

public class DollyDriver : MonoBehaviour
{
	[SerializeField] private CinemachineVirtualCamera virtualCamera;
	[SerializeField] private float cycleTime = 10.0f;

	private CinemachineTrackedDolly dolly;
	private float pathPositionMax;
	private float pathPositionMin;
	private StartTimer timer;

	private void Start()
	{
		timer = GameObject.Find("Timer").GetComponent<StartTimer>();

		// �o�[�`�����J�������Z�b�g����Ă��Ȃ���Β��~
		if (this.virtualCamera == null)
		{
			this.enabled = false;
			return;
		}

		// �h���[�R���|�[�l���g���擾�ł��Ȃ���Β��~
		this.dolly = this.virtualCamera.GetCinemachineComponent<CinemachineTrackedDolly>();
		if (this.dolly == null)
		{
			this.enabled = false;
			return;
		}

		// Position�̒P�ʂ��g���b�N��̃E�F�C�|�C���g�ԍ���ɂ���悤�ݒ�
		this.dolly.m_PositionUnits = CinemachinePathBase.PositionUnits.PathUnits;

		// �E�F�C�|�C���g�̍ő�ԍ��E�ŏ��ԍ����擾
		this.pathPositionMax = this.dolly.m_Path.MaxPos;
		this.pathPositionMin = this.dolly.m_Path.MinPos;
	}

	private void Update()
	{
		if (timer.CountDownTime >= 0)
        {
			var t = 0.5f - (0.5f * Mathf.Cos((Time.time * 2.0f * Mathf.PI) / this.cycleTime));
			this.dolly.m_PathPosition = Mathf.Lerp(this.pathPositionMin, this.pathPositionMax, t);
        }
		
	}
}