🎮 Vampire Survivors — Web3 Powered Edition
Powered by Unity • Somnia Data Streams • Wallet Leaderboards • On-Chain Score Claim System
<p align="center"> <img src="https://github.com/Arya4546/vampire_survivors/raw/main/preview/banner.png" width="100%" /> </p>
🚀 About the Project

This is a Web3-enhanced Vampire Survivors clone made in Unity 6, loaded with:

⚔️ Smooth top-down survival gameplay

🧟 Enemy wave system

📈 Live leaderboard synced to Somnia Data Streams

🧾 Secure on-chain score publishing

💰 One-tap ERC-20 claim flow

👾 WebGL Ready + Optimized

Yeh project traditional gameplay + blockchain mechanics ka solid fusion hai.
Perfect for hackathons, demos, and Somnia ecosystem integrations.

✨ Key Features
🕹️ Survival Gameplay

Auto-attacking character

Increasing difficulty

Timer system

XP, level, upgrades… sab kuch!

💾 On-Chain Score Upload

Handled by APIUploader.cs (✔ included in this repo)

✔ Score automatically pushes to Somnia API
✔ Uses player's wallet from PlayerPrefs
✔ Clean JSON payload
✔ Error + success logs

<details> <summary><strong>APIUploader.cs Source</strong></summary>
// Full file included in repo


📄 File Ref: 

APIUploader

</details>
🏆 Real-Time Leaderboard

Fully dynamic leaderboard powered by:

Somnia Data Streams API

Auto-refresh

Top 10 players

First 3 = green highlight

Others = red highlight

<details> <summary><strong>LeaderboardManager.cs</strong></summary>
// Full file included in repo


📄 File Ref: 

LeaderboardManager

</details>
💳 Claim Rewards (ERC-20 Flow)

Users can directly claim tokens based on in-game score.

Triggered via UI button

Uses Web3 BlockchainManager (your custom system)

Auto-disables button after claim

Handles loading, success, failure gracefully

<details> <summary><strong>ClaimButtonHandler.cs</strong></summary>
// Full file included in repo


📄 File Ref: 

ClaimButtonHandler

</details>
🧩 Project Structure
/Assets
   /Scripts
      APIUploader.cs
      LeaderboardManager.cs
      ClaimButtonHandler.cs
   /UI
      Leaderboard UI
      Claim UI
   /Gameplay
      Player
      Enemies
      Managers

🛠️ Tech Stack
Category	Tools
Engine	Unity 6 (6000.0.46f1)
Platform	WebGL
Web3	Somnia Ecosystem
Networking	UnityWebRequest
UI	TextMeshPro + Custom Canvas
🌐 Web3 Integrations
🔌 Somnia Data Streams

Live player score publishing

Cloud leaderboard syncing

Minimal latency

🪙 ERC-20 Reward Claim

Reward = Final Score
Smooth end-to-end flow with:

Transaction screen

Loading overlay

Success callback

UI lockout to prevent re-claims

📸 Screenshots
<p align="center"> <img src="https://github.com/Arya4546/vampire_survivors/raw/main/preview/screen1.png" width="45%" /> <img src="https://github.com/Arya4546/vampire_survivors/raw/main/preview/screen2.png" width="45%" /> </p>
🧪 How to Run (Local Setup)

Clone repo

git clone https://github.com/Arya4546/vampire_survivors.git


Open in Unity 6

Set wallet before playing

PlayerPrefs.SetString("WALLET_ADDRESS", "your-wallet-here");


Hit Play!

Build → WebGL for deployment

🚀 Deployment

WebGL build can be hosted on:

Netlify

Vercel

GitHub Pages

Somnia Arcade

Just drag & drop the build folder — done.

🙌 Credits

Developer: Arya4546

Web3 Flow: Somnia Ecosystem

Game Logic: Unity Vamp Survivors-style mechanics

If you use this repo — drop a ⭐ on GitHub ❤️
