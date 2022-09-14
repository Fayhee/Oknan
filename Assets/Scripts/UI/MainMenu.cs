using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Oknan
{
    public class MainMenu : MonoBehaviour
    {
        
        private GameObject GlobalManager;
        public GameObject pauseMenu;
        public GameObject MintNFTMenu;
        public GameObject VoucherMintNFTMenu;
        public GameObject VerifyMenu;
        public GameObject SignMenu;
        public GameObject TransferMenu;
        public GameObject ContractMenu;
        public GameObject VoucherMenu;
        public GameObject MarketplaceMenu;
        public GameObject WelcomeMenu;
        public GameObject AchievementText;
        public Text CoinsText;

        // Start is called before the first frame update
        void Awake()
        {
            GlobalManager = GameObject.FindGameObjectWithTag("Global");
            pauseMenu.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {

                pauseMenu.SetActive(true);
                FindObjectOfType<AudioManager2>().Play("Pop");
                Cursor.visible = true;
                Time.timeScale = 0;
            }

        }

        public void OnResumePressed()
        {
            pauseMenu.SetActive(false);
            FindObjectOfType<AudioManager2>().Play("Pop");
            Time.timeScale = 1;

        }

        // makes menus pop up

        public void OpenVoucherMenu()
        {
            if (GlobalManager.GetComponent<Global>().globalCoins > 0)
            {
                FindObjectOfType<AudioManager2>().Play("Pop");
                VoucherMenu.SetActive(true);
            }
            else
            {
                Debug.Log("Get More Coins!");
            }
        }

        public void OpenMintNFTMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            MintNFTMenu.SetActive(true);
        }

        public void OpenVoucherMintNFTMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            VoucherMintNFTMenu.SetActive(true);
        }

        public void OpenVerifyMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            VerifyMenu.SetActive(true);
        }

        public void OpenSignMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            SignMenu.SetActive(true);
        }

        public void OpenTransferMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            TransferMenu.SetActive(true);
        }

        public void OpenContractMenu()
        {

            FindObjectOfType<AudioManager2>().Play("Pop");
            ContractMenu.SetActive(true);
        }

        public void OpenMarketplaceMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            MarketplaceMenu.SetActive(true);
        }
        // menu close buttons, usually you would subtract a coin once the blockchain call has suceeded, I've just done it here to show you how in the voucher script

        public void CloseVoucherMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            if (GlobalManager.GetComponent<Global>().globalCoins > 0)
            {
                GlobalManager.GetComponent<Global>().globalCoins -= 1;
                CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            }
            VoucherMenu.SetActive(false);
        }

        public void CloseMintNFTMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            MintNFTMenu.SetActive(false);
        }

        async public void CloseVoucherMintNFTMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            VoucherMintNFTMenu.SetActive(false);
            AchievementText.SetActive(true);
            await new WaitForSeconds(5);
            AchievementText.SetActive(false);
        }

        public void CloseVerifyMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            VerifyMenu.SetActive(false);
        }

        public void CloseSignMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            SignMenu.SetActive(false);
        }

        public void CloseTransferMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            TransferMenu.SetActive(false);
        }

        public void CloseContractMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            CoinsText.text = "Coins: " + GlobalManager.GetComponent<Global>().globalCoins.ToString();
            ContractMenu.SetActive(false);
        }

        public void CloseMarketplaceMenu()
        {
            FindObjectOfType<AudioManager2>().Play("Pop");
            MarketplaceMenu.SetActive(false);
        }


        public void OpenMarketplace()
        {
            Application.OpenURL("https://marketplace-ui.onrender.com/");
        }
    }
}
