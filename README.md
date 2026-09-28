# DevExpress EXE static-analysis workspace

Place the EXE you want to inspect under `samples/`, for example:

`samples/target.exe`

Then open **Actions → Static Analyze .NET EXE → Run workflow**.

The workflow performs static analysis only; it does **not execute the target EXE**. The resulting `dotnet-static-analysis` artifact contains hashes, PE/.NET metadata, class/method inventories, and decompiled code suitable for security review. Files whose names clearly indicate crack/keygen/license-bypass implementation are excluded from the downloadable decompiled artifact.
