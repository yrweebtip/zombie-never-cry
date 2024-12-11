using UnityEngine;

public class Autolockmouse : MonoBehaviour
{
    void Start()
    {
        LockCursor();
    }

    void Update()
    {
        // Tekan tombol Escape untuk keluar dari mode terkunci
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            UnlockCursor();
        }

        // Tekan tombol kiri mouse untuk kembali ke mode terkunci
        if (Input.GetMouseButtonDown(0))
        {
            LockCursor();
        }
    }

    void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked; // Mengunci kursor ke tengah layar
        Cursor.visible = false; // Menyembunyikan kursor
    }

    void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None; // Membebaskan kursor
        Cursor.visible = true; // Menampilkan kursor
    }
}

