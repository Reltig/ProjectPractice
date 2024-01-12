from PIL import Image

from fastapi import FastAPI, File, UploadFile

app = FastAPI()

net = models.resnet34()
net.fc = torch.nn.Linear(512, 2) #TODO: заменить
net.load_state_dict(torch.load("model.pt"))

def transform(img):
    normalize = transforms.Normalize(mean=[0.485, 0.456, 0.406],
                                             std=[0.229, 0.224, 0.225])
    return transforms.Compose([
        transforms.CenterCrop(1200),
        transforms.Resize(256),
        transforms.CenterCrop(224),
        transforms.ToTensor(),
        normalize
    ])(img)

@app.post("/uploadfile/")
async def create_upload_file(file: UploadFile):
    img = Image.open(io.BytesIO(await file.read()))
    tensor = transform(img)
    batch = torch.stack([tensor])
    output = net(batch)
    predicted = output.argmax().item()
    return predicted

# uvicorn main:app --host 0.0.0.0 --port 8000