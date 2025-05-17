using UnityEngine;

[System.Serializable]
public class RecoilSettings
{
    [Header("Основные параметры")]
    public float verticalRecoil = 1.5f;    // Вертикальная отдача
    public float horizontalRecoil = 0.5f;  // Горизонтальная отдача (разброс)
    public float duration = 0.1f;          // Длительность отдачи
    public float recoverySpeed = 2f;       // Скорость восстановления

    [Header("Дополнительно")]
    public float maxVerticalAngle = 15f;   // Макс. угол по вертикали
    public float randomness = 0.3f;        // Случайный фактор
    public AnimationCurve recoilCurve;     // Кривая отдачи
}

public class AdvancedCameraRecoil : MonoBehaviour
{
    public RecoilSettings singleFireSettings;
    public RecoilSettings automaticSettings;

    [SerializeField] private bool isAutomaticWeapon = false;
    [SerializeField] private float recoilResetDelay = 0.2f;

    private Vector3 currentRotation;
    private Vector3 targetRotation;
    private float recoilTime;
    private bool isApplyingRecoil;
    private float lastFireTime;

    private void Awake()
    {
        // Инициализация кривой отдачи по умолчанию
        singleFireSettings.recoilCurve = new AnimationCurve(
            new Keyframe(0, 0),
            new Keyframe(0.3f, 1),
            new Keyframe(1, 0)
        );

        automaticSettings.recoilCurve = singleFireSettings.recoilCurve;
    }

    private void Update()
    {
        ProcessInput();
        UpdateRecoil();
        ApplyRotation();
    }

    private void ProcessInput()
    {
        bool shouldFire = isAutomaticWeapon ?
            Input.GetMouseButton(0) : Input.GetMouseButtonDown(0);

        if (shouldFire && Time.time > lastFireTime + recoilResetDelay)
        {
            ApplyWeaponRecoil();
            lastFireTime = Time.time;
        }
    }

    private void ApplyWeaponRecoil()
    {
        RecoilSettings settings = isAutomaticWeapon ? automaticSettings : singleFireSettings;

        // Рассчитываем отдачу с учетом случайного фактора
        float vertical = settings.verticalRecoil *
                        (1 + Random.Range(-settings.randomness, settings.randomness));

        float horizontal = settings.horizontalRecoil *
                         Random.Range(-1f, 1f);

        targetRotation += new Vector3(
            -vertical,
            horizontal,
            0
        );

        // Ограничиваем максимальные углы
        targetRotation.x = Mathf.Clamp(
            targetRotation.x,
            -settings.maxVerticalAngle,
            settings.maxVerticalAngle
        );

        isApplyingRecoil = true;
        recoilTime = 0f;
    }

    private void UpdateRecoil()
    {
        RecoilSettings settings = isAutomaticWeapon ? automaticSettings : singleFireSettings;

        if (isApplyingRecoil)
        {
            recoilTime += Time.deltaTime;

            if (recoilTime >= settings.duration)
            {
                isApplyingRecoil = false;
            }
        }
        else
        {
            // Плавное возвращение в исходное положение
            targetRotation = Vector3.Lerp(
                targetRotation,
                Vector3.zero,
                settings.recoverySpeed * Time.deltaTime
            );
        }

        // Применяем кривую для плавности
        float curveValue = isApplyingRecoil ?
            settings.recoilCurve.Evaluate(recoilTime / settings.duration) : 1f;

        currentRotation = Vector3.Lerp(
            currentRotation,
            targetRotation,
            curveValue * settings.recoverySpeed * Time.deltaTime
        );
    }

    private void ApplyRotation()
    {
        transform.localRotation = Quaternion.Euler(currentRotation);
    }

    // Метод для смены режима оружия
    public void SetWeaponMode(bool isAutomatic)
    {
        isAutomaticWeapon = isAutomatic;
    }

    // Метод для внешнего вызова отдачи (например, из скрипта оружия)
    public void AddRecoil(float verticalForce, float horizontalForce)
    {
        targetRotation += new Vector3(-verticalForce, horizontalForce, 0);
        isApplyingRecoil = true;
        recoilTime = 0f;
    }
}