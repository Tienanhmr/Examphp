const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');

const app = express();
const PORT = 3000;

mongoose.connect('mongodb://localhost:27017', {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});

const ProductSchema = new mongoose.Schema({
  ProductCode: String,
  ProductName: String,
  ProductDate: Date,
  ProductOriginPrice: Number,
  Quantity: Number,
  ProductStoreCode: String,
});

const Product = mongoose.model('Product', ProductSchema);

app.use(bodyParser.json());
app.set('view engine', 'ejs');

app.use(express.static('public'));

app.get('/', async (req, res) => {
  try {
    const products = await Product.find().sort({ ProductStoreCode: -1 });
    res.render('index', { products });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

app.post('/api/products', async (req, res) => {
  try {
    const product = await Product.create(req.body);
    res.json(product);
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

app.delete('/api/products/:id', async (req, res) => {
  try {
    await Product.findByIdAndDelete(req.params.id);
    res.json({ success: true });
  } catch (error) {
    res.status(500).json({ error: error.message });
  }
});

app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});
