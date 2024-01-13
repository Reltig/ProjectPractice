import torch
from torchvision import transforms
from torchvision import models
from PIL import Image
import io
from datetime import datetime

from fastapi import FastAPI, File, UploadFile

map = ["Амарант", "Щавель"]
history = []

app = FastAPI()

net = torch.load("full_model.pt")

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
    result = {"date": datetime.now().strftime("%Y/%m/%d %H:%M:%S"), "name": map[predicted], "accuracy": 88, "density": 8, "mode": 8}
    history.append(result)
    return result

@app.get("/history")
async def get_history():
    return history

# uvicorn main:app --host 0.0.0.0 --port 8000
