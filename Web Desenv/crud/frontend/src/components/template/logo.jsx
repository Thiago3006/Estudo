import './logo.css'
import logo from '../../assets/images/logo1.png'
import React from 'react'
import { Link } from 'react-router-dom'

export default props =>
<aside className="logo1">
    <Link to="/" className="logo1">
        <img src={logo} alt="logo1" />
    </Link>
</aside>