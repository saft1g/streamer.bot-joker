# Preparations
## note: Amazon Polly is free for under 5mio letters; above this 5mio letters the service is fee-based.

### AWS Account and IAM User
To get access to AWS Polly Test2Speech Service you need an AWS account. https://aws.amazon.com/
Create IAM User https://console.aws.amazon.com/iamv2/home?#/home and add Group AmazonPollyFullAccess.
Write down the user credentials (AccessKey PublicKey PrivateKey)

### Install AWSCli
https://docs.aws.amazon.com/cli/v1/userguide/cli-chap-welcome.html
https://docs.aws.amazon.com/polly/latest/dg/setup-aws-cli.html


Add path to environment

### Configure AWSCli
on command line run "aws configure" and add your AccesKey, Secret AccessKey and region
https://docs.aws.amazon.com/cli/v1/userguide/cli-configure-quickstart.html
regions: https://docs.aws.amazon.com/general/latest/gr/rande.html

### Set Variables
set the voice you want to use.
In the "execute code" part, you have to change the paths where the created mp3 will be saved and adjust the "Play Sound".

### Voices List
List of voice IDs -> src/polly-voices.json