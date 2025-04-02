SHELL := pwsh.exe
FILE := 02_programStructure.cs

.PHONY: run clean

run:
# Create PlayGround (if missing)
#	powershell -Command "ni -ItemType Directory -Path '.\PlayGround' -Force"
# Copy content from source file to .\PlayGround\Program.cs
	$(SHELL) -Command "Set-Content -Path .\PlayGround\Program.cs -Value (gc -Path $(FILE))"
# Run the project
	cd PlayGround && dotnet run

.SILENT:
clean:
	$(SHELL) -Command "rm .\PlayGround\* -Exclude 'Project.csproj' -Recurse -Force -ErrorAction Ignore"
